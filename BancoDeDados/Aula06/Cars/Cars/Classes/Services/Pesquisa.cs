using Cars.Classes.Contextos;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.IdentityModel.Tokens;

namespace Cars.Classes.Services
{
    static class Pesquisa
    {
        //Campo
        static EstoqueContexto contexto = new EstoqueContexto();

        //métodos
        public static void Pesquisas(bool moto, bool carro, string texto, DataGridView dataGridView1)
        {
            if (moto.Equals(false) & carro.Equals(false))
            {
                if (texto.IsNullOrEmpty())
                {
                    dataGridView1.DataSource = contexto.Estoque.Select(e => new
                    {
                        e.Tipo,
                        e.Modelo,
                        e.Quantidade,
                        Valor = e.Valor.ToString("C"),
                    }).ToList();
                }
                else
                {
                    dataGridView1.DataSource = contexto.Estoque.Where(e => e.Modelo.Contains(texto)).Select(e => new
                    {
                        e.Tipo,
                        e.Modelo,
                        e.Quantidade,
                        Valor = e.Valor.ToString("C"),
                    }).ToList();
                }
            }
            else if (moto)
            {
                //Pesquisa
                dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 1).Select(e => new
                {
                    e.Tipo,
                    e.Modelo,
                    e.Quantidade,
                    Valor = e.Valor.ToString("C")
                }).ToList();
            }
            else if (carro)
            {
                dataGridView1.DataSource = contexto.Estoque.Where(e => e.Tipo == 2).Select(e => new
                {
                    e.Tipo,
                    e.Modelo,
                    e.Quantidade,
                    Valor = e.Valor.ToString("C")
                }).ToList();
            }
        }


            private static void Filtro()
        {

        }
        }
    }
