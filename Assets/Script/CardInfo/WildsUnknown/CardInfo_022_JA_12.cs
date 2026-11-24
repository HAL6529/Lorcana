using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_022_JA_12 : CardInfo
{
    public CardInfo_022_JA_12()
    {
        this.cardNo = "022_JA_12";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デール";
        this.cardName2 = "スパイク大作戦";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Chipmunk;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
