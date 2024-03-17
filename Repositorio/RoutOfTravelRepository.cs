using Microsoft.Data.SqlClient;
using Modelos;
using Repositoy.Interfaces;
using System.Data;

namespace Repositoy
{
    public class RoutOfTravelRepository : IRepositoryBase<TravelRoute>
    {
        private readonly string _srtSqlServer;

        public RoutOfTravelRepository(string SrtSqlServer)
        {
            _srtSqlServer = SrtSqlServer;
        }
        public async Task<bool> DeleteAsycn(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("EliminarRutaDeViaje", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdRutaViaje", id);
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

        public async Task<IEnumerable<TravelRoute>> GetAllAsycn()
        {
            var travelRoute = new List<TravelRoute>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("SeleccionarTodasRutasDeViaje", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var travelsRoute = new TravelRoute()
                                    {
                                        Id = rd.GetInt32(0),
                                        IdConductor = rd.GetInt32(1),
                                        IdRoute = rd.GetInt32(2),
                                        IdBus = rd.GetInt32(3)
                                    };
                                    travelRoute.Add(travelsRoute);
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
            return travelRoute;
        }

        public async Task<TravelRoute> GetByIdAsync(int id)
        {
            TravelRoute travel;
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerTravelPorId", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdTravel", id);
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            rd.ReadAsync().Wait();
                            travel = new TravelRoute()
                            {
                                Id = rd.GetInt32(0),
                                IdConductor = rd.GetInt32(1),
                                IdRoute = rd.GetInt32(2),
                                IdBus = rd.GetInt32(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return travel;
        }

        public async Task<bool> InsertAsycn(TravelRoute model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("CrearRutaDeViaje", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdConductor", model.IdConductor);
                        cmd.Parameters.AddWithValue("@IdRuta", model.IdRoute);
                        cmd.Parameters.AddWithValue("@IdAutobus", model.IdBus);
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

        public async Task<bool> UpdateAsycn(TravelRoute model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarRutaDeViaje", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdRutaViaje", model.Id);
                        cmd.Parameters.AddWithValue("@IdConductor", model.IdConductor);
                        cmd.Parameters.AddWithValue("@IdRuta", model.IdRoute);
                        cmd.Parameters.AddWithValue("@IdAutobus", model.IdBus);
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
