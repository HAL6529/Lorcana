using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_227_JA_09 : CardInfo
{
    public CardInfo_227_JA_09()
    {
        this.cardNo = "227_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "くまのプーさん";
        this.cardName2 = "はちみつの魔法使い";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosRuiz;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer,  EnumController.Class.Hunny };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.WinnieThePooh;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
