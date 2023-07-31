import React from "react";

import GameBoardRow from "./GameBoardRow";
import "./GameBoard.css";

function GameBoard() {
  const row1 = [
    { cellId: 1, cellState: "unselected", cellTeam: "red", cellWord: "himalayas" },
    { cellId: 2, cellState: "selected", cellTeam: "blue", cellWord: "mercury" },
    { cellId: 3, cellState: "unselected", cellTeam: "red", cellWord: "iceland" },
    { cellId: 4, cellState: "unselected", cellTeam: "blue", cellWord: "organ" },
    { cellId: 5, cellState: "selected", cellTeam: "red", cellWord: "cross" },
  ];

  const row2 = [
    { cellId: 6, cellState: "unselected", cellTeam: "blue", cellWord: "jumper" },
    { cellId: 7, cellState: "unselected", cellTeam: "blue", cellWord: "penny" },
    { cellId: 8, cellState: "selected", cellTeam: "red", cellWord: "camp" },
    { cellId: 9, cellState: "unselected", cellTeam: "red", cellWord: "potter" },
    { cellId: 10, cellState: "unselected", cellTeam: "blue", cellWord: "chalk" },
  ];

  const row3 = [
    { cellId: 11, cellState: "selected", cellTeam: "blue", cellWord: "lion" },
    { cellId: 12, cellState: "unselected", cellTeam: "red", cellWord: "golf" },
    { cellId: 13, cellState: "unselected", cellTeam: "blue", cellWord: "foot" },
    { cellId: 14, cellState: "unselected", cellTeam: "assassin", cellWord: "memory" },
    { cellId: 15, cellState: "unselected", cellTeam: "blue", cellWord: "texas" },
  ];

  const row4 = [
    { cellId: 16, cellState: "unselected", cellTeam: "red", cellWord: "ear" },
    { cellId: 17, cellState: "unselected", cellTeam: "red", cellWord: "cycle" },
    { cellId: 18, cellState: "unselected", cellTeam: "blue", cellWord: "tunnel" },
    { cellId: 19, cellState: "unselected", cellTeam: "red", cellWord: "nail" },
    { cellId: 20, cellState: "unselected", cellTeam: "red", cellWord: "director" },
  ];

  const row5 = [
    { cellId: 21, cellState: "unselected", cellTeam: "red", cellWord: "tuxedo" },
    { cellId: 22, cellState: "unselected", cellTeam: "blue", cellWord: "brazil" },
    { cellId: 23, cellState: "selected", cellTeam: "blue", cellWord: "lumberjack" },
    { cellId: 24, cellState: "selected", cellTeam: "red", cellWord: "link" },
    { cellId: 25, cellState: "unselected", cellTeam: "blue", cellWord: "shell" },
  ];

  const board = [row1, row2, row3, row4, row5];

  return (
    <section className="gameboard">
      {board.map((row) => (
        <GameBoardRow row={row} />
      ))}
    </section>
  );
}

export default GameBoard;
