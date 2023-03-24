using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class TicketDatos
    {
        public async Task<DataTable> DevolverAsync()
        {

            DataTable dt = new DataTable();
            try
            {
                string sql = "Select * from Ticket;";

                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return dt;
        }

        public async Task<bool> InsertarAsync(Ticket ticket)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO ticket VALUES (@Usuario, @Fecha, @Cliente, @TiposSoporte, @DescripcionS, @DescripcionR, @Precio, @Impuesto, @Descuento, @Total);";
                
                using (MySqlConnection _conexion = new MySqlConnection(Conexion.cadena))
                {
                    
                    await _conexion.OpenAsync();
                   
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Fecha", MySqlDbType.DateTime, 10).Value = ticket.Fecha;
                        comando.Parameters.Add("@Cliente", MySqlDbType.VarChar, 50).Value = ticket.Cliente;
                        comando.Parameters.Add("@TiposSoporte", MySqlDbType.VarChar, 50).Value = ticket.TipoSoporte;
                        comando.Parameters.Add("@DescripcionS", MySqlDbType.VarChar, 4000).Value = ticket.DescripcionS;
                        comando.Parameters.Add("@DescripcionR", MySqlDbType.VarChar, 4000).Value = ticket.DescripcionR;
                        comando.Parameters.Add("@Precio", MySqlDbType.Double).Value = ticket.Precio;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Double).Value = ticket.Impuesto;
                        comando.Parameters.Add("@Total", MySqlDbType.Double).Value = ticket.Total;

                        inserto = true;

                        await comando.ExecuteNonQueryAsync();
                      
                    }
                    
                }

            }
            catch (Exception)
            {
            }
            return inserto;
        }
    }
}
