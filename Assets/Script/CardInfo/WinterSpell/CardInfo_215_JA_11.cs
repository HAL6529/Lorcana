using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_215_JA_11 : CardInfo
{
    public CardInfo_215_JA_11()
    {
        this.cardNo = "215_JA_11";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エルサ";
        this.cardName2 = "心配する姉";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.HollieHibbert;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
