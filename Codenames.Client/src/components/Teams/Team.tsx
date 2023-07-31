import "./Team.css";

type TeamProps = {
  team: string;
  currentTeam: string;
};

function Team({ team, currentTeam }: TeamProps) {
  const score = 8;
  const classes = `team turn-${team === currentTeam ? team : "off"}`;

  return (
    <section className={classes}>
      <h2 className="team-header">{team}</h2>
      <div className="team-score">
        <p>{score}</p>
      </div>
      {team === currentTeam && <button className={`btn-${team}`}>End Turn</button>}
    </section>
  );
}

export default Team;
