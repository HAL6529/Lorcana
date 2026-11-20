using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_210_JA_09 : CardInfo
{
    public CardInfo_210_JA_09()
    {
        this.cardNo = "210_JA_09";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エルサ";
        this.cardName2 = "雪の女王";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.NicholasKole;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Queen, EnumController.Class.Sorcerer};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
