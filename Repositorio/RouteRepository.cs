using Microsoft.Data.SqlClient;
using Modelos;
using Repositoy.Interfaces;
using System.Data;

namespace Repositoy
{
    public class RouteRepository : IRepositoryModelBase<Route>
    {
        private readonly string _srtSqlServer;

        public RouteRepository(string SrtSqlServer)
        {
            _srtSqlServer = SrtSqlServer;
        }

        public async Task<bool> ChangeTheStateAsync(int idRoute, int? idConductor, int? idAutobus, bool Available)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarRutaPorEntidad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdRuta", idRoute);
                        cmd.Parameters.AddWithValue("@IdConductor", (idConductor == null) ? DBNull.Value : idConductor);
                        cmd.Parameters.AddWithValue("@IdAutobus", (idAutobus == null) ? DBNull.Value : idAutobus);
                        cmd.Parameters.AddWithValue("@ValorDisponibilidad", Available);

                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteAsycn(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("EliminarRuta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdRuta", id);
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<IEnumerable<Route>> GetAllAsycn()
        {
            var routes = new List<Route>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("SeleccionarTodasRutas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var route = new Route
                                    {
                                        Id = rd.GetInt32(0),
                                        Name = rd.GetString(1),
                                        Description = rd.GetString(2),
                                        IdConductor = (!rd.IsDBNull(3) ? rd.GetInt32(3) : null),
                                        IdBus = (!rd.IsDBNull(4) ? rd.GetInt32(4) : null),
                                        availability = rd.GetBoolean(5),
                                    };

                                    routes.Add(route);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return routes;
        }

        public async Task<IEnumerable<Route>> GetAvailableAsync()
        {
            var routes = new List<Route>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerRutasDisponibles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var route = new Route
                                    {
                                        Id = rd.GetInt32(0),
                                        Name = rd.GetString(1),
                                        Description = rd.GetString(2),
                                        IdConductor = (!rd.IsDBNull(3) ? rd.GetInt32(3) : null),
                                        IdBus = (!rd.IsDBNull(4) ? rd.GetInt32(4) : null),
                                        availability = rd.GetBoolean(5),
                                    };

                                    routes.Add(route);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return routes;
        }

        public async Task<Route> GetByIdAsync(int id)
        {
            Route route = new Route();
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerRutaPorId", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdRuta", id);
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            rd.ReadAsync().Wait();
                            if (rd.HasRows)
                            {
                                route.Id = rd.GetInt32(0);
                                route.Name = rd.GetString(1);
                                route.Description = rd.GetString(2);
                                route.IdConductor = (!rd.IsDBNull(3) ? rd.GetInt32(3) : null);
                                route.IdBus = (!rd.IsDBNull(4) ? rd.GetInt32(4) : null);
                                route.availability = rd.GetBoolean(5);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return route;
        }

        public async Task<bool> InsertAsycn(Route model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("CrearRuta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", model.Name);
                        cmd.Parameters.AddWithValue("@Descripcion", model.Description);
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateAsycn(Route model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarRuta", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdRuta", model.Id);
                        cmd.Parameters.AddWithValue("@Nombre", model.Name);
                        cmd.Parameters.AddWithValue("@Descripcion", model.Description);
                        await conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
