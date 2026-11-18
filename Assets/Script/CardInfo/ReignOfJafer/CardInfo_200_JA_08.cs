using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_200_JA_08 : CardInfo
{
    public CardInfo_200_JA_08()
    {
        this.cardNo = "200_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "スティッチ";
        this.cardName2 = "エイリアンの暴れん坊";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JeannePlounevezAndTheonidas;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
