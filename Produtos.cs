using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaLoja
{
    class Produtos:EntidadeBase
    {
        string nome;
        Categoria categoria;
        Marca marca;
        float valorpago;
        float valordevenda;
        DateTime datadacompra;

        //Opcionais
        string tamanho;
        bool condição;
        string descricao;

    }



}
