using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_11 : CardInfo
{
    public CardInfo_042_JA_11()
    {
        this.cardNo = "042_JA_11";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ポカホンタス";
        this.cardName2 = "風の導くままに";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Pocahontas;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
