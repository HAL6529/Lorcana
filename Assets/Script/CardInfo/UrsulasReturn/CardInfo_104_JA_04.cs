using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_104_JA_04 : CardInfo
{
    public CardInfo_104_JA_04()
    {
        this.cardNo = "104_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒxƒ“ƒWƒƒ";
        this.cardName2 = "‘å’_‚È’cŒ‹Žå‹`ŽÒ";
        this.power = 5;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
