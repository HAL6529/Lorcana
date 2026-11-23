using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_11 : CardInfo
{
    public CardInfo_170_JA_11()
    {
        this.cardNo = "170_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "隠されたワナ";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.EvaWidermann;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
