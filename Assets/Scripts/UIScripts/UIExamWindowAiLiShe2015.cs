﻿using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIExamWindowAiLiShe2015 : UIExamWindowBase
{
    [Space(20)]
    public Image imgAnceLight;
    public Image imgOpenLight;
    public Image imgHeadFar;
    public Image imgFrontFog;

    public Button btnControlRight;
    public Button btnControlClose;
    public Button btnControlLeft;

    //public ButtonState btsControlForward;
    //public ButtonState btsControlNormal;
    //public ButtonState btsControlBackward;

    public ButtonState btsDoubleJump;

    public Transform transControlRod;

    public class ControlRod
    {
        public GameObject objRoot;

        public Image imgHeadLight;
        public Sprite sprHeadLight0;
        public Sprite sprHeadLight1;
        public Sprite sprHeadLight2;

        public Image imgFogLight;
        public Sprite sprFogLight0;
        public Sprite sprFogLight1;
        public Sprite sprFogLight3;
    }


    public ControlRod controlRodForward;
    public ControlRod controlRodNormal;
    public ControlRod controlRodBackward;

    public override bool FrontFogSwitch
    {
        set
        {
            if (FrontFogSwitch != value)
            {
                base.FrontFogSwitch = value;
                //controlRodNormal.imgFogLight.sprite = RearFogSwitch ? controlRodNormal.sprFoglight2 : value ? controlRodNormal.sprFogLight1 : controlRodNormal.sprFogLight0;
                //controlRodBackward.imgFogLight.sprite = RearFogSwitch ? controlRodBackward.sprFoglight2 : value ? controlRodBackward.sprFogLight1 : controlRodBackward.sprFogLight0;

                imgFrontFog.DOFade(FrontFogLamp ? 1f : 0f, 0);
            }
        }
    }
    public override bool LeftIndicatorSwitch
    {
        set
        {
            if (LeftIndicatorSwitch != value)
            {
                base.LeftIndicatorSwitch = value;
                if (value)
                {
                    transControlRod.localEulerAngles = new Vector3(0, 0, 5);
                }
                else if (!RightIndicatorSwitch)
                {
                    transControlRod.localEulerAngles = new Vector3(0, 0, 0);
                }
            }
        }
    }
    public override bool RightIndicatorSwitch
    {
        set
        {
            if (RightIndicatorSwitch != value)
            {
                base.RightIndicatorSwitch = value;
                if (value)
                {
                    transControlRod.localEulerAngles = new Vector3(0, 0, -5);
                }
                else if (!LeftIndicatorSwitch)
                {
                    transControlRod.localEulerAngles = new Vector3(0, 0, 0);
                }
            }
        }
    }
    public override bool DoubleJumpSwitch
    {
        set
        {
            if (DoubleJumpSwitch != value)
            {
                base.DoubleJumpSwitch = value;
                (btsDoubleJump.button.targetGraphic as Image).sprite = value ? btsDoubleJump.sprSelect : btsDoubleJump.sprNormal;
            }
        }
    }

    public override bool FarHeadlightSwitch
    {
        set
        {
            if (FarHeadlightSwitch != value)
            {
                base.FarHeadlightSwitch = value;
                //TODO：UI标识
                //(btsControlState.button.targetGraphic as Image).sprite = value ? btsCantrolState.sprSelect : btsCantrolState.sprNormal;

                //imgHeadNear.DOFade(LowBeamLight ? 1f : 0f, 0);
                imgHeadFar.DOFade(HigBeamLight ? 1f : 0f, 0);
            }
        }
    }

    public override void OnCreate()
    {
        base.OnCreate();

    }

}