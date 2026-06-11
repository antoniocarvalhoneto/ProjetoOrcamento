using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ProjetoOrcamento.Deita
{
    internal class Dados
    {
        private static int _proximoNumeroPedido = 1;
        private static List<Orcamento> _orcamentos = new();
        private static List<Cliente> _clientes = new();
        private static List<Servico> _servicos = new();

        private static readonly string _caminhoArquivo = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ProjetoOrcamento",
            "dados.json"
        );

        private static readonly string _caminhoClientes = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ProjetoOrcamento",
            "clientes.json"
        );

        private static readonly string _caminhoServicos = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "ProjetoOrcamento",
            "servicos.json"
        );

        internal static int ProximoNumeroPedido
        {
            get => _proximoNumeroPedido;
            set => _proximoNumeroPedido = value;
        }

        internal static List<Orcamento> Orcamentos => _orcamentos;
        internal static List<Cliente> Clientes => _clientes;
        internal static List<Servico> Servicos => _servicos;

        static Dados()
        {
            Carregar();
        }

        // ========== ORÇAMENTOS ==========
        internal static void AdicionarOrcamento(Orcamento orcamento)
        {
            _orcamentos.Add(orcamento);
            SalvarOrcamentos();
        }

        internal static void AtualizarOrcamento(Orcamento orcamento)
        {
            var index = _orcamentos.FindIndex(o => o.Id == orcamento.Id);
            if (index >= 0)
            {
                _orcamentos[index] = orcamento;
                SalvarOrcamentos();
            }
        }

        internal static void RemoverOrcamento(Guid id)
        {
            _orcamentos.RemoveAll(o => o.Id == id);
            SalvarOrcamentos();
        }

        internal static Orcamento ObterOrcamento(Guid id)
        {
            return _orcamentos.FirstOrDefault(o => o.Id == id);
        }

        // ========== CLIENTES ==========
        internal static void AdicionarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new InvalidOperationException("Nome do cliente é obrigatório.");

            _clientes.Add(cliente);
            SalvarClientes();
        }

        internal static void AtualizarCliente(int index, Cliente cliente)
        {
            if (index >= 0 && index < _clientes.Count)
            {
                _clientes[index] = cliente;
                SalvarClientes();
            }
        }

        internal static void RemoverCliente(int index)
        {
            if (index >= 0 && index < _clientes.Count)
            {
                _clientes.RemoveAt(index);
                SalvarClientes();
            }
        }

        // ========== SERVIÇOS ==========
        internal static void AdicionarServico(Servico servico)
        {
            if (string.IsNullOrWhiteSpace(servico.Nome))
                throw new InvalidOperationException("Nome do serviço é obrigatório.");

            if (servico.PrecoUnitario <= 0)
                throw new InvalidOperationException("Preço do serviço deve ser maior que zero.");

            _servicos.Add(servico);
            SalvarServicos();
        }

        internal static void AtualizarServico(int index, Servico servico)
        {
            if (index >= 0 && index < _servicos.Count)
            {
                _servicos[index] = servico;
                SalvarServicos();
            }
        }

        internal static void RemoverServico(int index)
        {
            if (index >= 0 && index < _servicos.Count)
            {
                _servicos.RemoveAt(index);
                SalvarServicos();
            }
        }

        // ========== PERSISTÊNCIA ==========
        private static void SalvarOrcamentos()
        {
            try
            {
                var diretorio = Path.GetDirectoryName(_caminhoArquivo);
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);

                var opcoes = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(_orcamentos, opcoes);
                File.WriteAllText(_caminhoArquivo, json);

                SalvarConfiguracao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar orçamentos: {ex.Message}", "Erro");
            }
        }

        private static void SalvarClientes()
        {
            try
            {
                var diretorio = Path.GetDirectoryName(_caminhoClientes);
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);

                var opcoes = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(_clientes, opcoes);
                File.WriteAllText(_caminhoClientes, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar clientes: {ex.Message}", "Erro");
            }
        }

        private static void SalvarServicos()
        {
            try
            {
                var diretorio = Path.GetDirectoryName(_caminhoServicos);
                if (!Directory.Exists(diretorio))
                    Directory.CreateDirectory(diretorio);

                var opcoes = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(_servicos, opcoes);
                File.WriteAllText(_caminhoServicos, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar serviços: {ex.Message}", "Erro");
            }
        }

        private static void Carregar()
        {
            try
            {
                CarregarConfiguracao();
                CarregarOrcamentos();
                CarregarClientes();
                CarregarServicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro");
            }
        }

        private static void CarregarOrcamentos()
        {
            try
            {
                if (File.Exists(_caminhoArquivo))
                {
                    var json = File.ReadAllText(_caminhoArquivo);
                    _orcamentos = JsonSerializer.Deserialize<List<Orcamento>>(json) ?? new();
                }
            }
            catch { }
        }

        private static void CarregarClientes()
        {
            try
            {
                if (File.Exists(_caminhoClientes))
                {
                    var json = File.ReadAllText(_caminhoClientes);
                    _clientes = JsonSerializer.Deserialize<List<Cliente>>(json) ?? new();
                }
            }
            catch { }
        }

        private static void CarregarServicos()
        {
            try
            {
                if (File.Exists(_caminhoServicos))
                {
                    var json = File.ReadAllText(_caminhoServicos);
                    _servicos = JsonSerializer.Deserialize<List<Servico>>(json) ?? new();
                }
            }
            catch { }
        }

        private static void SalvarConfiguracao()
        {
            try
            {
                var caminhoConfig = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "ProjetoOrcamento",
                    "config.json"
                );
                var config = new { ProximoNumeroPedido = _proximoNumeroPedido };
                var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoConfig, json);
            }
            catch { }
        }

        private static void CarregarConfiguracao()
        {
            try
            {
                var caminhoConfig = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "ProjetoOrcamento",
                    "config.json"
                );
                if (File.Exists(caminhoConfig))
                {
                    var json = File.ReadAllText(caminhoConfig);
                    var doc = JsonDocument.Parse(json);
                    if (doc.RootElement.TryGetProperty("ProximoNumeroPedido", out var prop))
                    {
                        _proximoNumeroPedido = prop.GetInt32();
                    }
                }
            }
            catch { }
        }
    }
}
