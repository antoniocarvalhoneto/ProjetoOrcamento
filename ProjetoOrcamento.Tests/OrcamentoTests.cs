using System;
using System.Collections.Generic;
using Xunit;
using ProjetoOrcamento.Deita;

public class OrcamentoTests
{
    [Fact]
    public void Orcamento_DeveTerStatusPendenteAoCriar()
    {
        // Arrange & Act
        var orcamento = new Orcamento();

        // Assert
        Assert.Equal(StatusOrcamento.Pendente, orcamento.Status);
    }

    [Fact]
    public void Orcamento_DeveGerarIDUnicopoAoCriar()
    {
        // Arrange & Act
        var orcamento1 = new Orcamento();
        var orcamento2 = new Orcamento();

        // Assert
        Assert.NotEqual(orcamento1.Id, orcamento2.Id);
    }

    [Fact]
    public void CalcularTotal_DeveRetornarZeroComListaVazia()
    {
        // Arrange
        var orcamento = new Orcamento();

        // Act
        var total = orcamento.CalcularTotal();

        // Assert
        Assert.Equal(0, total);
    }

    [Fact]
    public void CalcularTotal_DeveRetornarSomaCorreta()
    {
        // Arrange
        var orcamento = new Orcamento();
        var servico1 = new Servico("Consultoria", 100m);
        var servico2 = new Servico("Desenvolvimento", 200m);

        orcamento.Itens.Add(new ItemOrcamento { Servico = servico1, Quantidade = 2 });
        orcamento.Itens.Add(new ItemOrcamento { Servico = servico2, Quantidade = 1 });

        // Act
        var total = orcamento.CalcularTotal();

        // Assert
        Assert.Equal(400m, total); // (100 * 2) + (200 * 1) = 400
    }

    [Fact]
    public void Aprovar_DeveMudarStatusParaAprovado()
    {
        // Arrange
        var orcamento = new Orcamento();
        var servico = new Servico("Consultoria", 100m);
        orcamento.Itens.Add(new ItemOrcamento { Servico = servico, Quantidade = 1 });

        // Act
        orcamento.Aprovar();

        // Assert
        Assert.Equal(StatusOrcamento.Aprovado, orcamento.Status);
    }

    [Fact]
    public void Aprovar_DeveGerarNumeroPedidoSequencial()
    {
        // Arrange
        var orcamento1 = new Orcamento();
        var orcamento2 = new Orcamento();
        var servico = new Servico("Consultoria", 100m);
        orcamento1.Itens.Add(new ItemOrcamento { Servico = servico, Quantidade = 1 });
        orcamento2.Itens.Add(new ItemOrcamento { Servico = servico, Quantidade = 1 });

        // Act
        orcamento1.Aprovar();
        var numeroPedido1 = orcamento1.NumeroPedido;

        orcamento2.Aprovar();
        var numeroPedido2 = orcamento2.NumeroPedido;

        // Assert
        Assert.NotNull(numeroPedido1);
        Assert.NotNull(numeroPedido2);
        Assert.Equal(numeroPedido1 + 1, numeroPedido2);
    }

    [Fact]
    public void Aprovar_DeveLancarExcecaoQuandoNaoHaItens()
    {
        // Arrange
        var orcamento = new Orcamento();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => orcamento.Aprovar());
    }

    [Fact]
    public void Rejeitar_DeveMudarStatusParaRejeitado()
    {
        // Arrange
        var orcamento = new Orcamento();
        var motivo = "Fora do orçamento";

        // Act
        orcamento.Rejeitar(motivo);

        // Assert
        Assert.Equal(StatusOrcamento.Rejeitado, orcamento.Status);
    }

    [Fact]
    public void Rejeitar_DeveArmazenarMotivo()
    {
        // Arrange
        var orcamento = new Orcamento();
        var motivo = "Fora do orçamento";

        // Act
        orcamento.Rejeitar(motivo);

        // Assert
        Assert.Equal(motivo, orcamento.MotivoRejeicao);
    }

    [Fact]
    public void Rejeitar_DeveLancarExcecaoQuandoMotivoVazio()
    {
        // Arrange
        var orcamento = new Orcamento();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => orcamento.Rejeitar(""));
        Assert.Throws<InvalidOperationException>(() => orcamento.Rejeitar(null));
        Assert.Throws<InvalidOperationException>(() => orcamento.Rejeitar("   "));
    }

    [Fact]
    public void ItemOrcamento_DeveCalcularSubtotalCorreto()
    {
        // Arrange
        var servico = new Servico("Consultoria", 150m);
        var item = new ItemOrcamento { Servico = servico, Quantidade = 3 };

        // Act
        var subtotal = item.Subtotal;

        // Assert
        Assert.Equal(450m, subtotal); // 150 * 3 = 450
    }
}
