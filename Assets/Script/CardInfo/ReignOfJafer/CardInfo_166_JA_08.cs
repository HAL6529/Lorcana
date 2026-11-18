using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_166_JA_08 : CardInfo
{
    public CardInfo_166_JA_08()
    {
        this.cardNo = "166_JA_08";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "スティッチ";
        this.cardName2 = "試作品626号";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatteoMarzocco;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Alien };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
