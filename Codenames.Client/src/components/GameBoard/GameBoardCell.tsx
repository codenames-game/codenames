import React from "react";

import styles from "./GameBoardCell.module.css";

type GameBoardCellProps = {
  cell: {
    cellId: number;
    cellState: string;
    cellTeam: string;
    cellWord: string;
  };
};

function GameBoardCell({ cell }: GameBoardCellProps) {
  const isSpymaster = true;
  const isSelected = false;

  //   const playerClassName = isSpymaster ? `styles[spymaster-${cell.cellTeam}]` : `styles.operative`;
  //   const selectedClassName = `styles[selected-${cell.cellTeam}]`;

  return <button className={styles["gameboard-cell"]}>{cell.cellWord}</button>;
}

export default GameBoardCell;
