using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_234_JA_03 : CardInfo
{
    public CardInfo_234_JA_03()
    {
        this.cardNo = "234_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "さあいよいよオリンポスだ！";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.TomekPietrzyk;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
