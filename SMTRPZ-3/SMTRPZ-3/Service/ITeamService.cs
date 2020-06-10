using SMTRPZ_3.Dto;
using System.Collections.Generic;

namespace SMTRPZ_3.Service
{
    public interface ITeamService
    {
        TeamDto CreateTeam(TeamDto TeamDto);
        TeamDto RemoveTeam(int id);
        TeamDto UpdateTeam(TeamDto TeamDto);
        TeamDto GetTeam(int id);
        List<TeamDto> GetAllTeams();
    }
}
