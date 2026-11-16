using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_220_JA_06 : CardInfo
{
    public CardInfo_220_JA_06()
    {
        this.cardNo = "220_JA_06";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "レック・イット・ラルフ";
        this.cardName2 = "剛腕の壊し屋";
        this.power = 4;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.JakeParker;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.WreckItRalph;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
