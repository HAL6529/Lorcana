using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_01 : CardInfo
{
    public CardInfo_140_JA_01()
    {
        this.cardNo = "140_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉIÅ[ÉçÉâ";
        this.cardName2 = "óDâÎÇ»ïP";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = "Samanta Erdini";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
