using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class LoginService
    {
        private SignInManager<CustomIdentityUser> _singInManager;
        private TokenService _tokenService;

        public LoginService(SignInManager<CustomIdentityUser> singInManager, TokenService tokenService)
        {
            _singInManager = singInManager;
            _tokenService = tokenService;
        }

        public Result LogarUsuario(LoginRequest request)
        {
            var resultadoIdentity = _singInManager
                .PasswordSignInAsync(request.UserName, request.Password, false, false);
            if (resultadoIdentity.Result.Succeeded)
            {
                var identityUser = _singInManager
                    .UserManager
                    .Users
                    .FirstOrDefault(usuario => usuario.NormalizedUserName == request.UserName.ToUpper());
                Token token = _tokenService
                    .CreateToken(identityUser, _singInManager
                    .UserManager.GetRolesAsync(identityUser).Result
                    .FirstOrDefault());
                return Result.Ok().WithSuccess(token.Value);
            }
            return Result.Fail("Login Falhou");
        }

        public Result ResetaSenhaUsuario(EfetuaResetRequest request)
        {
            CustomIdentityUser identityUser = RecuperaUsuarioPorEmail(request.Email);

            IdentityResult resultadoIdentity = _singInManager
                .UserManager
                .ResetPasswordAsync(identityUser,request.Token, request.Password)
                .Result;
            if(resultadoIdentity.Succeeded) return Result.Ok().WithSuccess("Senha redefinida com sucesso");
            return Result.Fail("houve um erro na operação");


        }

        public Result SolicitaResetSenhaUsuario(SolicitaResetRequest request)
        {
            CustomIdentityUser identityUser = RecuperaUsuarioPorEmail(request.Email);

            if (identityUser != null)
            {
                string codigoDeRecuperacao = _singInManager
                    .UserManager.GeneratePasswordResetTokenAsync(identityUser).Result;
                return Result.Ok().WithSuccess(codigoDeRecuperacao);
            }
            return Result.Fail("Falha ao solicitar Redefinição");
        }

        private CustomIdentityUser RecuperaUsuarioPorEmail(string email)
        {
            return _singInManager
                .UserManager
                .Users
                .FirstOrDefault(u => u.NormalizedEmail == email.ToUpper());
        }
    }
}
