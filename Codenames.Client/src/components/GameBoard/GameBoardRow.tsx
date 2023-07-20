import React from "react";

import GameBoardCell from "./GameBoardCell";
import styles from "./GameBoardRow.module.css";

type GameBoardRowProps = {
  row: { cellId: number; cellState: string; cellTeam: string; cellWord: string }[];
};

function GameBoardRow({ row }: GameBoardRowProps) {
  return (
    <section className={styles["gameboard-row"]}>
      {row.map((cell) => (
        <GameBoardCell cell={cell} />
      ))}
    </section>
  );
}

export default GameBoardRow;
