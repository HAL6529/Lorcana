using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_13 : CardInfo
{
    public CardInfo_071_JA_13()
    {
        this.cardNo = "071_JA_13";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "魔法のはちみつの杖";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.KaitlinCuthbertson;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.ItemHunny;
        this.rare = EnumController.Rare.Uncommon;
    }
}
