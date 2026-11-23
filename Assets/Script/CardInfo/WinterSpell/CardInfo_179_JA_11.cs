using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_11 : CardInfo
{
    public CardInfo_179_JA_11()
    {
        this.cardNo = "179_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "チーフ";
        this.cardName2 = "歴戦の猟犬";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
