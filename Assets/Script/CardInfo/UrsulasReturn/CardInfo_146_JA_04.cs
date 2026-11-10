using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_146_JA_04 : CardInfo
{
    public CardInfo_146_JA_04()
    {
        this.cardNo = "146_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉnÉìÉX";
        this.cardName2 = "çÇãMÇ»à´ì}";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DustinPanzinoAndLeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
