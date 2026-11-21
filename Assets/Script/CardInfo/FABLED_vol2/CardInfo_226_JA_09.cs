using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_226_JA_09 : CardInfo
{
    public CardInfo_226_JA_09()
    {
        this.cardNo = "226_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "熟練なるミスティーク";
        this.power = 4;
        this.toughness = 4;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
