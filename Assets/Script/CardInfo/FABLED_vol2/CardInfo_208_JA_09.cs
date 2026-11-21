using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_208_JA_09 : CardInfo
{
    public CardInfo_208_JA_09()
    {
        this.cardNo = "208_JA_09";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "アースラ";
        this.cardName2 = "海の魔女";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JohnLoren;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.TheLittleMermaid;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
