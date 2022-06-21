using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    internal class Enumerador
    {
        
        enum Status
        {
            Ok = 200,
            Redirecionamento_Permanente = 301,
            Nao_Encontrado = 404,
            Nao_Autorizado = 405,
            Servidor_Indisponivel = 503,
            Tempo_Esgotado = 504
        }
    }
}

//Código 200, Descrição: Ok.
//Código 301, Descrição: Redirecionamento permanente.
//Código 404, Descrição: Não encontrado.
//Código 405, Descrição: Não autorizado.
//Código 503, Descrição: Servidor indisponível.
//Código 504, Descrição: Tempo esgotado. 
