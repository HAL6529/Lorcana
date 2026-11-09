using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_045_JA_02 : CardInfo
{
    public CardInfo_045_JA_02()
    {
        this.cardNo = "045_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "クスコ";
        this.cardName2 = "追われているラマ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MichaelaMartin;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
