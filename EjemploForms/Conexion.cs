using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//este es el que contiene la declaración del DataTable
using System.Data;

namespace EjemploForms
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = test; Uid = root; Pwd =; Port = 3306");
        }

        public DataTable getPokemons() {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        public DataTable getPokemonPorNombre(String nombre)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = 
                    new MySqlCommand("SELECT * FROM pokemon where name ='" + nombre + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }

        public void ActualizaPokemon(String id, String weight, String height, String habitat)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = 
                    new MySqlCommand("UPDATE pokemon SET weight='"+ weight + "', height='"+height+ "', habitat='" + habitat + "' WHERE id='"+id+"'" , conexion);
                consulta.ExecuteNonQuery();
                conexion.Close();
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

    }
}
