using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_08 : CardInfo
{
    public CardInfo_068_JA_08()
    {
        this.cardNo = "068_JA_08";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "イズマ";
        this.cardName2 = "ギリギリセーフ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JulienVandois;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
