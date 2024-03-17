using Microsoft.Data.SqlClient;
using Modelos;
using Repositoy.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repositoy
{

    public class ConductorsRepository : IRepositoryModelBase<Conductor>
    {
        private readonly string _srtSqlServer;

        public ConductorsRepository(string SrtSqlServer)
        {
            _srtSqlServer = SrtSqlServer;
        }

        public async Task<bool> ChangeTheStateAsync(int idConductor, int? idBus, int? idRoute, bool Available)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarConductorPorEntidad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdConductor", idConductor);
                        cmd.Parameters.AddWithValue("@IdAutobus", (idBus==null)? DBNull.Value: idBus);
                        cmd.Parameters.AddWithValue("@IdRuta", (idRoute == null) ? DBNull.Value : idRoute);
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

        public async Task<IEnumerable<Conductor>> GetAvailableAsync()
        {
            var conductors = new List<Conductor>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerConductoresDisponibles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var conductor = new Conductor()
                                    {
                                        Id = rd.GetInt32(0),
                                        FirstName = rd.GetString(1),
                                        LastName = rd.GetString(2),
                                        Birthdate = rd.GetDateTime(3).Date,
                                        DNI = rd.GetString(4),
                                        IdBus = (!rd.IsDBNull(5) ? rd.GetInt32(5) : null),
                                        Idroute = (!rd.IsDBNull(6)) ? rd.GetInt32(6) : null,
                                        availability = rd.GetBoolean(7)
                                    };
                                    conductors.Add(conductor);
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

            return conductors;
        }

        public  async Task<bool> DeleteAsycn(int id)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("EliminarConductor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdConductor", id);
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

        public async Task<IEnumerable<Conductor>> GetAllAsycn()
        {
            var conductors = new List<Conductor>();

            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("SeleccionarTodosConductores", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            if (rd.HasRows)
                            {
                                while (await rd.ReadAsync())
                                {
                                    var conductor = new Conductor
                                    {
                                        Id = rd.GetInt32(0),
                                        FirstName = rd.GetString(1),
                                        LastName = rd.GetString(2),
                                        Birthdate = rd.GetDateTime(3).Date,
                                        DNI = rd.GetString(4),
                                        IdBus = (!rd.IsDBNull(5) ? rd.GetInt32(5) : null),
                                        Idroute = (!rd.IsDBNull(6)) ? rd.GetInt32(6) : null,
                                        availability = rd.GetBoolean(7)
                                    };

                                    conductors.Add(conductor);
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
            return conductors;
         }

        public async Task<Conductor> GetByIdAsync(int id)
        {
            Conductor conductor;
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("VerConductorPorId", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdConductor", id);
                        await conn.OpenAsync();
                        using (var rd = await cmd.ExecuteReaderAsync())
                        {
                            rd.ReadAsync().Wait();
                            conductor = new Conductor()
                            {
                                Id = rd.GetInt32(0),
                                FirstName = rd.GetString(1),
                                LastName = rd.GetString(2),
                                Birthdate = rd.GetDateTime(3).Date,
                                DNI = rd.GetString(4),
                                IdBus = (!rd.IsDBNull(5) ? rd.GetInt32(5) : null),
                                Idroute = (!rd.IsDBNull(6)) ? rd.GetInt32(6) : null,
                                availability = rd.GetBoolean(7)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conductor;
        }

        public async Task<bool> InsertAsycn(Conductor model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("CrearConductor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre",model.FirstName);
                        cmd.Parameters.AddWithValue("@Apellido", model.LastName);
                        cmd.Parameters.AddWithValue("@FechaNac", model.Birthdate);
                        cmd.Parameters.AddWithValue("@Cedula", model.DNI);
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

        public async Task<bool> UpdateAsycn(Conductor model)
        {
            try
            {
                using (var conn = new SqlConnection(_srtSqlServer))
                {
                    using (var cmd = new SqlCommand("ActualizarConductor", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdConductor", model.Id);
                        cmd.Parameters.AddWithValue("@Nombre", model.FirstName);
                        cmd.Parameters.AddWithValue("@Apellido", model.LastName);
                        cmd.Parameters.AddWithValue("@FechaNac", model.Birthdate);
                        cmd.Parameters.AddWithValue("@Cedula", model.DNI);
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
