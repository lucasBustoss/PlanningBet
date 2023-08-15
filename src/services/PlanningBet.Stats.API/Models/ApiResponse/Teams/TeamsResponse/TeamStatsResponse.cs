using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse
{
    public class TeamStatsResponse
    {
        public TeamStatsResponse()
        {
        }

        #region GeneralStats

        [JsonPropertyName("seasonPPG_home")]
        public decimal TeamPointsPerGameHome { get; set; }

        [JsonPropertyName("seasonPPG_away")]
        public decimal TeamPointsPerGameAway { get; set; }

        [JsonPropertyName("seasonPPG_overall")]
        public decimal TeamPointsPerGameOverall { get; set; }

        [JsonPropertyName("seasonMatchesPlayed_home")]
        public int TeamMatchesPlayedHome { get; set; }

        [JsonPropertyName("seasonMatchesPlayed_away")]
        public decimal TeamMatchesPlayedAway { get; set; }

        [JsonPropertyName("seasonMatchesPlayed_overall")]
        public decimal TeamMatchesPlayedOverall { get; set; }

        [JsonPropertyName("seasonWinsNum_home")]
        public int TeamTotalWinsHome { get; set; }

        [JsonPropertyName("seasonWinsNum_away")]
        public int TeamTotalWinsAway { get; set; }

        [JsonPropertyName("seasonWinsNum_overall")]
        public int TeamTotalWinsOverall { get; set; }

        [JsonPropertyName("winPercentage_home")]
        public decimal TeamWinsPercentageHome { get; set; }

        [JsonPropertyName("winPercentage_away")]
        public decimal TeamWinsPercentageAway { get; set; }

        [JsonPropertyName("winPercentage_overall")]
        public decimal TeamWinsPercentageOverall { get; set; }

        [JsonPropertyName("firstGoalScoredPercentage_home")]
        public decimal TeamFirstGoalScoredPercentageHome { get; set; }

        [JsonPropertyName("firstGoalScoredPercentage_away")]
        public decimal TeamFirstGoalScoredPercentageAway { get; set; }

        [JsonPropertyName("firstGoalScoredPercentage_overall")]
        public decimal TeamFirstGoalScoredPercentageOverall { get; set; }

        [JsonPropertyName("seasonCSPercentage_home")]
        public decimal TeamCleanSheetPercentageHome { get; set; }

        [JsonPropertyName("seasonCSPercentage_away")]
        public decimal TeamCleanSheetPercentageAway { get; set; }

        [JsonPropertyName("seasonCSPercentage_overall")]
        public decimal TeamCleanSheetPercentageOverall { get; set; }

        [JsonPropertyName("seasonFTSPercentage_home")]
        public decimal TeamFailedToScorePercentageHome { get; set; }

        [JsonPropertyName("seasonFTSPercentage_away")]
        public decimal TeamFailedToScorePercentageAway { get; set; }

        [JsonPropertyName("seasonFTSPercentage_overall")]
        public decimal TeamFailedToScorePercentageOverall { get; set; }

        [JsonPropertyName("seasonBTTSPercentage_home")]
        public int TeamBothTeamsToScoredHome { get; set; }

        [JsonPropertyName("seasonBTTSPercentage_away")]
        public int TeamBothTeamsToScoredAway { get; set; }

        [JsonPropertyName("seasonBTTSPercentage_overall")]
        public int TeamBothTeamsToScoredOverall { get; set; }

        [JsonPropertyName("seasonScoredNum_home")]
        public int TeamGoalsScoredHome { get; set; }

        [JsonPropertyName("seasonScoredNum_away")]
        public int TeamGoalsScoredAway { get; set; }

        [JsonPropertyName("seasonScoredNum_overall")]
        public int TeamGoalsScoredOverall { get; set; }

        [JsonPropertyName("seasonConcededNum_home")]
        public int TeamGoalsConcededHome { get; set; }

        [JsonPropertyName("seasonConcededNum_away")]
        public int TeamGoalsConcededAway { get; set; }

        [JsonPropertyName("seasonConcededNum_overall")]
        public int TeamGoalsConcededOverall { get; set; }

        [JsonPropertyName("seasonScoredAVG_home")]
        public decimal TeamAvgGoalsScoredHome { get; set; }

        [JsonPropertyName("seasonScoredAVG_away")]
        public decimal TeamAvgGoalsScoredAway { get; set; }

        [JsonPropertyName("seasonScoredAVG_overall")]
        public decimal TeamAvgGoalsScoredOverall { get; set; }

        [JsonPropertyName("seasonConcededAVG_home")]
        public decimal TeamAvgGoalsConcededHome { get; set; }

        [JsonPropertyName("seasonConcededAVG_away")]
        public decimal TeamAvgGoalsConcededAway { get; set; }

        [JsonPropertyName("seasonConcededAVG_overall")]
        public decimal TeamAvgGoalsConcededOverall { get; set; }

        [JsonPropertyName("seasonAVG_home")]
        public decimal TeamAvgTotalGoalsHome { get; set; }

        [JsonPropertyName("seasonAVG_away")]
        public decimal TeamAvgTotalGoalsAway { get; set; }

        [JsonPropertyName("seasonAVG_overall")]
        public decimal TeamAvgTotalGoalsOverall { get; set; }

        [JsonPropertyName("shotsAVG_home")]
        public decimal TeamAvgShotsHome { get; set; }

        [JsonPropertyName("shotsAVG_away")]
        public decimal TeamAvgShotsAway { get; set; }

        [JsonPropertyName("shotsAVG_overall")]
        public decimal TeamAvgShotsOverall { get; set; }

        [JsonPropertyName("shotsOnTargetAVG_home")]
        public decimal TeamAvgShotsOnTargetHome { get; set; }

        [JsonPropertyName("shotsOnTargetAVG_away")]
        public decimal TeamAvgShotsOnTargetAway { get; set; }

        [JsonPropertyName("shotsOnTargetAVG_overall")]
        public decimal TeamAvgShotsOnTargetOverall { get; set; }

        [JsonPropertyName("xg_for_avg_home")]
        public decimal TeamXgForHome { get; set; }

        [JsonPropertyName("xg_for_avg_away")]
        public decimal TeamXgForAway { get; set; }

        [JsonPropertyName("xg_for_avg_overall")]
        public decimal TeamXgForOverall { get; set; }

        [JsonPropertyName("xg_against_avg_home")]
        public decimal TeamXgAgainstHome { get; set; }

        [JsonPropertyName("xg_against_avg_away")]
        public decimal TeamXgAgainstAway { get; set; }

        [JsonPropertyName("xg_against_avg_overall")]
        public decimal TeamXgAgainstOverall { get; set; }

        #endregion

        #region HT Stats

        [JsonPropertyName("leadingAtHTPercentage_home")]
        public decimal TeamWinPercentageHTHome { get; set; }

        [JsonPropertyName("leadingAtHTPercentage_away")]
        public decimal TeamWinPercentageHTAway { get; set; }

        [JsonPropertyName("leadingAtHTPercentage_overall")]
        public decimal TeamWinPercentageHTOverall { get; set; }

        [JsonPropertyName("drawingAtHTPercentage_home")]
        public decimal TeamDrawPercentageHTHome { get; set; }

        [JsonPropertyName("drawingAtHTPercentage_away")]
        public decimal TeamDrawPercentageHTAway { get; set; }

        [JsonPropertyName("drawingAtHTPercentage_overall")]
        public decimal TeamDrawPercentageHTOverall { get; set; }

        [JsonPropertyName("trailingAtHTPercentage_home")]
        public decimal TeamLosePercentageHTHome { get; set; }

        [JsonPropertyName("trailingAtHTPercentage_away")]
        public decimal TeamLosePercentageHTAway { get; set; }

        [JsonPropertyName("trailingAtHTPercentage_overall")]
        public decimal TeamLosePercentageHTOverall { get; set; }

        [JsonPropertyName("seasonFTSPercentageHT_home")]
        public decimal TeamFailedToScorePercentageHTHome { get; set; }

        [JsonPropertyName("seasonFTSPercentageHT_away")]
        public decimal TeamFailedToScorePercentageHTAway { get; set; }

        [JsonPropertyName("seasonFTSPercentageHT_overall")]
        public decimal TeamFailedToScorePercentageHTOverall { get; set; }

        [JsonPropertyName("seasonCSPercentageHT_home")]
        public decimal TeamCleanSheetPercentageHTHome { get; set; }

        [JsonPropertyName("seasonCSPercentageHT_away")]
        public decimal TeamCleanSheetPercentageHTAway { get; set; }

        [JsonPropertyName("seasonCSPercentageHT_overall")]
        public decimal TeamCleanSheetPercentageHTOverall { get; set; }

        [JsonPropertyName("scoredGoalsHT_home")]
        public int TeamGoalsScoredHTHome { get; set; }

        [JsonPropertyName("scoredGoalsHT_away")]
        public int TeamGoalsScoredHTAway { get; set; }

        [JsonPropertyName("scoredGoalsHT_overall")]
        public int TeamGoalsScoredHTOverall { get; set; }

        [JsonPropertyName("concededGoalsHT_home")]
        public int TeamGoalsConcededHTHome { get; set; }

        [JsonPropertyName("concededGoalsHT_away")]
        public int TeamGoalsConcededHTAway { get; set; }

        [JsonPropertyName("concededGoalsHT_overall")]
        public int TeamGoalsConcededHTOverall { get; set; }

        [JsonPropertyName("scoredAVGHT_home")]
        public decimal TeamAvgGoalsScoredHTHome { get; set; }

        [JsonPropertyName("scoredAVGHT_away")]
        public decimal TeamAvgGoalsScoredHTAway { get; set; }

        [JsonPropertyName("scoredAVGHT_overall")]
        public decimal TeamAvgGoalsScoredHTOverall { get; set; }

        [JsonPropertyName("concededAVGHT_home")]
        public decimal TeamAvgGoalsConcededHTHome { get; set; }

        [JsonPropertyName("concededAVGHT_away")]
        public decimal TeamAvgGoalsConcededHTAway { get; set; }

        [JsonPropertyName("concededAVGHT_overall")]
        public decimal TeamAvgGoalsConcededHTOverall { get; set; }

        #endregion

        #region FT Stats

        [JsonPropertyName("wins_2hg_percentage_home")]
        public decimal TeamWinPercentageFTHome { get; set; }

        [JsonPropertyName("wins_2hg_percentage_away")]
        public decimal TeamWinPercentageFTAway { get; set; }

        [JsonPropertyName("wins_2hg_percentage_overall")]
        public decimal TeamWinPercentageFTOverall { get; set; }

        [JsonPropertyName("draws_2hg_percentage_home")]
        public decimal TeamDrawPercentageFTHome { get; set; }

        [JsonPropertyName("draws_2hg_percentage_away")]
        public decimal TeamDrawPercentageFTAway { get; set; }

        [JsonPropertyName("draws_2hg_percentage_overall")]
        public decimal TeamDrawPercentageFTOverall { get; set; }

        [JsonPropertyName("losses_2hg_percentage_home")]
        public decimal TeamLosePercentageFTHome { get; set; }

        [JsonPropertyName("losses_2hg_percentage_away")]
        public decimal TeamLosePercentageFTAway { get; set; }

        [JsonPropertyName("losses_2hg_percentage_overall")]
        public decimal TeamLosePercentageFTOverall { get; set; }

        [JsonPropertyName("fts_2hg_percentage_home")]
        public decimal TeamFailedToScorePercentageFTHome { get; set; }

        [JsonPropertyName("fts_2hg_percentage_away")]
        public decimal TeamFailedToScorePercentageFTAway { get; set; }

        [JsonPropertyName("fts_2hg_percentage_overall")]
        public decimal TeamFailedToScorePercentageFTOverall { get; set; }

        [JsonPropertyName("cs_2hg_percentage_home")]
        public decimal TeamCleanSheetPercentageFTHome { get; set; }

        [JsonPropertyName("cs_2hg_percentage_away")]
        public decimal TeamCleanSheetPercentageFTAway { get; set; }

        [JsonPropertyName("cs_2hg_percentage_overall")]
        public decimal TeamCleanSheetPercentageFTOverall { get; set; }

        [JsonPropertyName("scored_2hg_home")]
        public int TeamGoalsScoredFTHome { get; set; }

        [JsonPropertyName("scored_2hg_away")]
        public int TeamGoalsScoredFTAway { get; set; }

        [JsonPropertyName("scored_2hg_overall")]
        public int TeamGoalsScoredFTOverall { get; set; }

        [JsonPropertyName("conceded_2hg_home")]
        public int TeamGoalsConcededFTHome { get; set; }

        [JsonPropertyName("conceded_2hg_away")]
        public int TeamGoalsConcededFTAway { get; set; }

        [JsonPropertyName("conceded_2hg_overall")]
        public int TeamGoalsConcededFTOverall { get; set; }

        [JsonPropertyName("scored_2hg_avg_home")]
        public decimal TeamAvgGoalsScoredFTHome { get; set; }

        [JsonPropertyName("scored_2hg_avg_away")]
        public decimal TeamAvgGoalsScoredFTAway { get; set; }

        [JsonPropertyName("scored_2hg_avg_overall")]
        public decimal TeamAvgGoalsScoredFTOverall { get; set; }

        [JsonPropertyName("conceded_2hg_avg_home")]
        public decimal TeamAvgGoalsConcededFTHome { get; set; }

        [JsonPropertyName("conceded_2hg_avg_away")]
        public decimal TeamAvgGoalsConcededFTAway { get; set; }

        [JsonPropertyName("conceded_2hg_avg_overall")]
        public decimal TeamAvgGoalsConcededFTOverall { get; set; }

        #endregion

        #region GoalsStats

        [JsonPropertyName("firstGoalScored_overall")]
        public int TeamFirstGoalScoredOverall { get; set; }

        [JsonPropertyName("firstGoalScored_home")]
        public int TeamFirstGoalScoredHome { get; set; }

        [JsonPropertyName("firstGoalScored_away")]
        public int TeamFirstGoalScoredAway { get; set; }

        [JsonPropertyName("goals_scored_min_0_to_15")]
        public int TeamGoalsScoredMin0To15Overall { get; set; }

        [JsonPropertyName("goals_scored_min_16_to_30")]
        public int TeamGoalsScoredMin16To30Overall { get; set; }

        [JsonPropertyName("goals_scored_min_31_to_45")]
        public int TeamGoalsScoredMin31To45Overall { get; set; }

        [JsonPropertyName("goals_conceded_min_0_to_15")]
        public int TeamGoalsConcededMin0To15Overall { get; set; }

        [JsonPropertyName("goals_conceded_min_16_to_30")]
        public int TeamGoalsConcededMin16To30Overall { get; set; }

        [JsonPropertyName("goals_conceded_min_31_to_45")]
        public int TeamGoalsConcededMin31To45Overall { get; set; }

        [JsonPropertyName("goals_scored_min_0_to_15_home")]
        public int TeamGoalsScoredMin0To15Home { get; set; }

        [JsonPropertyName("goals_scored_min_16_to_30_home")]
        public int TeamGoalsScoredMin16To30Home { get; set; }

        [JsonPropertyName("goals_scored_min_31_to_45_home")]
        public int TeamGoalsScoredMin31To45Home { get; set; }

        [JsonPropertyName("goals_conceded_min_0_to_15_home")]
        public int TeamGoalsConcededMin0To15Home { get; set; }

        [JsonPropertyName("goals_conceded_min_16_to_30_home")]
        public int TeamGoalsConcededMin16To30Home { get; set; }

        [JsonPropertyName("goals_conceded_min_31_to_45_home")]
        public int TeamGoalsConcededMin31To45Home { get; set; }

        [JsonPropertyName("goals_scored_min_0_to_15_away")]
        public int TeamGoalsScoredMin0To15Away { get; set; }

        [JsonPropertyName("goals_scored_min_16_to_30_away")]
        public int TeamGoalsScoredMin16To30Away { get; set; }

        [JsonPropertyName("goals_scored_min_31_to_45_away")]
        public int TeamGoalsScoredMin31To45Away { get; set; }

        [JsonPropertyName("goals_conceded_min_0_to_15_away")]
        public int TeamGoalsConcededMin0To15Away { get; set; }

        [JsonPropertyName("goals_conceded_min_16_to_30_away")]
        public int TeamGoalsConcededMin16To30Away { get; set; }

        [JsonPropertyName("goals_conceded_min_31_to_45_away")]
        public int TeamGoalsConcededMin31To45Away { get; set; }

        private List<string> goalsScoredHome;

        [JsonPropertyName("seasonGoals_home")]
        public List<string> GoalsScoredHome
        {
            get { return goalsScoredHome; }
            set
            {
                goalsScoredHome = value.Select(
                    gs => gs.Length > 2 ?
                        Convert.ToInt32(gs.Substring(0, 2)) :
                        Convert.ToInt32(gs)).OrderBy(value => value)
                    .Select(i => i.ToString()).ToList();
            }
        }

        private List<string> goalsScoredAway;

        [JsonPropertyName("seasonGoals_away")]
        public List<string> GoalsScoredAway
        {
            get { return goalsScoredAway; }
            set
            {
                goalsScoredAway = value.Select(
                    gs => gs.Length > 2 ?
                        Convert.ToInt32(gs.Substring(0, 2)) :
                        Convert.ToInt32(gs)).OrderBy(value => value)
                    .Select(i => i.ToString()).ToList();
            }
        }

        private List<string> goalsConcededHome;

        [JsonPropertyName("seasonConceded_home")]
        public List<string> GoalsConcededHome
        {
            get { return goalsConcededHome; }
            set
            {
                goalsConcededHome = value.Select(
                    gs => gs.Length > 2 ?
                        Convert.ToInt32(gs.Substring(0, 2)) :
                        Convert.ToInt32(gs)).OrderBy(value => value)
                    .Select(i => i.ToString()).ToList();
            }
        }

        private List<string> goalsConcededAway;

        [JsonPropertyName("seasonConceded_away")]
        public List<string> GoalsConcededAway
        {
            get { return goalsConcededAway; }
            set
            {
                goalsConcededAway = value.Select(
                    gs => gs.Length > 2 ?
                        Convert.ToInt32(gs.Substring(0, 2)) :
                        Convert.ToInt32(gs)).OrderBy(value => value)
                    .Select(i => i.ToString()).ToList();
            }
        }

        #endregion
    }
}
