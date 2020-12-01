
class ContadorVotos
{
    int totalVoterQtt;
    int validVoteQtt;
    int blankVoteQtt;
    int nullVoteQtt;

    public ContadorVotos(int totalVoterQtt, int validVoteQtt, int blankVoteQtt, int nullVoteQtt)
    {
        this.totalVoterQtt = totalVoterQtt;
        this.validVoteQtt = validVoteQtt;
        this.blankVoteQtt = blankVoteQtt;
        this.nullVoteQtt = nullVoteQtt;
    }

    public double getValidVotePercentual()
    {
        return (double) validVoteQtt / totalVoterQtt * 100;
    }

    public double getBlankVotePercentual()
    {
        return (double) blankVoteQtt / totalVoterQtt * 100;
    }

    public double getNullVotePercentual()
    {
        return (double) nullVoteQtt / totalVoterQtt * 100;
    }
}


