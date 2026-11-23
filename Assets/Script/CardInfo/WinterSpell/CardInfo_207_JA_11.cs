using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_207_JA_11 : CardInfo
{
    public CardInfo_207_JA_11()
    {
        this.cardNo = "207_JA_11";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "お気楽スノーボーダー";
        this.power = 4;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
