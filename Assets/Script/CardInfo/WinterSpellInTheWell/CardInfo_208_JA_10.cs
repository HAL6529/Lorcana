using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_208_JA_10 : CardInfo
{
    public CardInfo_208_JA_10()
    {
        this.cardNo = "208_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エルサ";
        this.cardName2 = "未知への探索";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ClioWolfensberger;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
