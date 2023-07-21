import React from "react";

import "./GameBoardCell.css";

type GameBoardCellProps = {
  cell: {
    cellId: number;
    cellState: string;
    cellTeam: string;
    cellWord: string;
  };
};

function GameBoardCell({ cell }: GameBoardCellProps) {
  const isSpymaster = false;
  const isSelected = cell.cellState == "selected" ? true : false;

  const selectedClass = `selected-${cell.cellTeam}`;
  const playerClass = isSpymaster ? `spymaster-${cell.cellTeam}` : `operative`;
  const classes = `gameboard-cell ${isSelected ? selectedClass : playerClass}`;

  return <button className={classes}>{cell.cellWord}</button>;
}

export default GameBoardCell;
