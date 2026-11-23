using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_11 : CardInfo
{
    public CardInfo_046_JA_11()
    {
        this.cardNo = "046_JA_11";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ミーコ";
        this.cardName2 = "拾い食うアライグマ";
        this.power = 1;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HeidiNeunhoffer;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
