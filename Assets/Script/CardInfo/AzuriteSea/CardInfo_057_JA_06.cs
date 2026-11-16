using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_057_JA_06 : CardInfo
{
    public CardInfo_057_JA_06()
    {
        this.cardNo = "057_JA_06";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ママ・オーディ";
        this.cardName2 = "はなれぐらしの秘術師";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MelMilton;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
