using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_10 : CardInfo
{
    public CardInfo_199_JA_10()
    {
        this.cardNo = "199_JA_10";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "メカ女王";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.AnneNeyens;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
