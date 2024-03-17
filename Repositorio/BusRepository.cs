using Microsoft.Data.SqlClient;
using Modelos;
using Repositoy.Interfaces;
using System.Data;

namespace Repositoy
{
    public class BusRepository : IRepositoryModelBase<Bus>
    {
        private readonly string _srtSqlServer;

        public BusRepository(string SrtSqlServer)
        {
            _srtSqlServer = SrtSqlServer;
        }

        public async Task<bool> ChangeTheStateAsync(int idBus, int? idConductor, int? idRoute, bool Available)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarAutobusPorEntidad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdAutobus", idBus);
                        cmd.Parameters.AddWithValue("@IdConductor", (idConductor==null)? DBNull.Value : idConductor);
                        cmd.Parameters.AddWithValue("@IdRuta", (idRoute==null)? DBNull.Value: idRoute);
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

        public async Task<IEnumerable<Bus>> GetAvailableAsync()
        {
            var buses = new List<Bus>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerAutobusesDisponibles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.OpenAsync().Wait();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var bus = new Bus()
                                    {
                                        Id = rd.GetInt32(0),
                                        Brand = rd.GetString(1),
                                        Model = rd.GetString(2),
                                        Plate = rd.GetString(3),
                                        Color = rd.GetString(4),
                                        Year = rd.GetDateTime(5),
                                        IdConductor = (!rd.IsDBNull(6)) ? rd.GetInt32(6) : null,
                                        Idroute = (!rd.IsDBNull(7)) ? rd.GetInt32(7) : null,
                                        availability = rd.GetBoolean(8)
                                    };
                                    buses.Add(bus);
                                }
                            }
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return buses;
        }

        public  async Task<bool> DeleteAsycn(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("EliminarAutobus", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdAutobus", id);
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

        public async Task<IEnumerable<Bus>> GetAllAsycn()
        {
            var buses = new List<Bus>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("SeleccionarTodosAutobuses", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var bus = new Bus()
                                    {
                                        Id = rd.GetInt32(0),
                                        Brand = rd.GetString(1),
                                        Model = rd.GetString(2),
                                        Plate = rd.GetString(3),
                                        Color = rd.GetString(4),
                                        Year = rd.GetDateTime(5),
                                        IdConductor = (!rd.IsDBNull(6)) ? rd.GetInt32(6) : null,
                                        Idroute = (!rd.IsDBNull(7)) ? rd.GetInt32(7) : null,
                                        availability = rd.GetBoolean(8)
                                    };
                                    buses.Add(bus);
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
            return buses;
         }

        public async Task<Bus> GetByIdAsync(int id)
        {
            Bus bus;
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerAutobusPorId", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdAutobus", id);
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            rd.ReadAsync().Wait();
                            bus = new Bus()
                            {
                                Id = rd.GetInt32(0),
                                Brand = rd.GetString(1),
                                Model = rd.GetString(2),
                                Plate = rd.GetString(3),
                                Color = rd.GetString(4),
                                Year = rd.GetDateTime(5),
                                IdConductor = (!rd.IsDBNull(6)) ? rd.GetInt32(6) : null,
                                Idroute = (!rd.IsDBNull(7)) ? rd.GetInt32(7) : null,
                                availability = rd.GetBoolean(8)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bus;
        }

        public async Task<bool> InsertAsycn(Bus model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("CrearAutobus", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Marca", model.Brand);
                        cmd.Parameters.AddWithValue("@Modelo", model.Model);
                        cmd.Parameters.AddWithValue("@Placa", model.Plate);
                        cmd.Parameters.AddWithValue("@Color", model.Color);
                        cmd.Parameters.AddWithValue("@Anio", model.Year);
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

        public async Task<bool> UpdateAsycn(Bus model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarAutobus", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdAutobus", model.Id);
                        cmd.Parameters.AddWithValue("@Marca", model.Brand);
                        cmd.Parameters.AddWithValue("@Modelo", model.Model);
                        cmd.Parameters.AddWithValue("@Placa", model.Plate);
                        cmd.Parameters.AddWithValue("@Color", model.Color);
                        cmd.Parameters.AddWithValue("@Anio", model.Year);
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
