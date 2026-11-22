using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_188_JA_10 : CardInfo
{
    public CardInfo_188_JA_10()
    {
        this.cardNo = "188_JA_10";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ウィンドダンサー市長";
        this.cardName2 = "元俳優の政治家";
        this.power = 5;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneGiovanardi;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
