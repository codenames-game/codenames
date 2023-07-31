import Team from "../Teams/Team";
import GameBoard from "../GameBoard/GameBoard";

import "./GameRoom.css";

function GameRoom() {
  let currentTeam = "red";

  return (
    <div className="gameroom">
      <Team team="red" currentTeam={currentTeam} />
      <GameBoard />
      <Team team="blue" currentTeam={currentTeam} />
    </div>
  );
}

export default GameRoom;
