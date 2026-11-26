using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_223_JA_14 : CardInfo
{
    public CardInfo_223_JA_14()
    {
        this.cardNo = "223_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "オーロラ";
        this.cardName2 = "喜びを歌う音楽家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AristeidisZentelis;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
