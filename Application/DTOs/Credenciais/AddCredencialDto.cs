﻿namespace Application.DTOs.Credenciais
{
    public class AddCredencialDto
    {
        public required int TipoUsuario { get; set; }
        public required string NomeUsuario { get; set; }
        public required string Senha { get; set; }
    }
}
