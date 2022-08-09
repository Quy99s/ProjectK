using System.Collections;
using System.Collections.Generic;
using AxieMixer.Unity;
using Spine.Unity;
using UnityEngine;

public class GameController : MonoBehaviour
{

    Axie2dBuilder builder => Mixer.Builder;
    private SkeletonAnimation skeletonAnimation;
    //   Start is called before the first frame update

    void Start()
    {
        Mixer.Init();
        skeletonAnimation = gameObject.GetComponent<SkeletonAnimation>();
        string axieId = PlayerPrefs.GetString("selectingId", "2727");
        string genes = PlayerPrefs.GetString("selectingGenes", "0x2000000000000300008100e08308000000010010088081040001000010a043020000009008004106000100100860c40200010000084081060001001410a04406");
        Mixer.SpawnSkeletonAnimation(skeletonAnimation, axieId, genes);
        skeletonAnimation.state.SetAnimation(0, "action/idle/normal", true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
