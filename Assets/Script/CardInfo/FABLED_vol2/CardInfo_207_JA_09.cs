using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_09 : CardInfo
{
    public CardInfo_207_JA_09()
    {
        this.cardNo = "207_JA_09";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "エイリアンダンサー";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AishaDurmagambetova;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
