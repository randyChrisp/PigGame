using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PigGame.Models
{
    public class Session
    {
        private ISession session;

        private const string GameKey = "pigGame";

        public Session(ISession session)
        {
            this.session = session;
        }

        public void SetGame(Game game)
        {
            session.SetObject(GameKey, game);
        }

        public Game GetGame()
        {
            return session.GetObject<Game>(GameKey) ?? new Game();
        }
    }
}
