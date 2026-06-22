using System;

namespace ProjetoOrcamento.Services
{
    internal static class AutorizacaoService
    {
        public static void ExigirAlteracao(Usuario usuario, string acao)
        {
            if (!usuario.PodeAlterarDados)
                throw new UnauthorizedAccessException($"Seu perfil não permite {acao}.");
        }

        public static void ExigirAdmin(Usuario usuario, string acao)
        {
            if (!usuario.EhAdmin)
                throw new UnauthorizedAccessException($"Apenas administradores podem {acao}.");
        }
    }
}
