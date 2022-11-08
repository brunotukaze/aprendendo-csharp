using SupermercadoMenorPreco;

GerenciamentoProduto produtoLimpeza1 = new GerenciamentoProduto();
produtoLimpeza1.produto = "Detergente";
produtoLimpeza1.fabricante = "YPE";
produtoLimpeza1.codigoDeBarra = 555214885215555251;
produtoLimpeza1.valorUnitario = 2.59;
produtoLimpeza1.valorCaixa = 24;
produtoLimpeza1.quantidadeEstoque = 200;

Console.WriteLine("O valor unitário do " + produtoLimpeza1.produto + " da marca " + produtoLimpeza1.fabricante + " é de R$ " + produtoLimpeza1.valorUnitario);
