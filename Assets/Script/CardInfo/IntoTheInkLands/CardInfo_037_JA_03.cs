using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_03 : CardInfo
{
    public CardInfo_037_JA_03()
    {
        this.cardNo = "037_JA_03";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ディアブロ";
        this.cardName2 = "忠実なペット";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
