using SMTRPZ_3.Dto;
using System.Collections.Generic;

namespace SMTRPZ_3.Service
{
    public interface IPlayerService
    {
        PlayerDto CreatePlayer(PlayerDto PlayerDto);
        PlayerDto RemovePlayer(int id);
        PlayerDto UpdatePlayer(PlayerDto PlayerDto);
        PlayerDto GetPlayer(int id);
        List<PlayerDto> GetAllPlayers();
    }
}
