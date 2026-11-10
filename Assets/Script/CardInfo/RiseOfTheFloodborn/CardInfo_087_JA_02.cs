using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_087_JA_02 : CardInfo
{
    public CardInfo_087_JA_02()
    {
        this.cardNo = "087_JA_02";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "パニック";
        this.cardName2 = "冥界の小悪魔";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KristinaChouriAndMarianaMoreno;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
