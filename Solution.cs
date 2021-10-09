// Find the total number of permutations (modulo 10000000007) of a staircase given that the person can step over one, two or three at a time.
public static int stepPerms(int staircaseLength)
{
    if(staircaseLength <= 2){
        return staircaseLength;
    }

    // recentPermutations[2] being the most recent permutation.
    List<long> recentPermutations = new List<long>(){
        1, 2, 4
    };

    for(int i=3; i<staircaseLength; i++){
        long totalPermutationsAtThisStep = recentPermutations.Sum();
        recentPermutations.Add(totalPermutationsAtThisStep);
        recentPermutations.RemoveAt(0);
    }

    return (int) (recentPermutations[2] % 10000000007);
}
