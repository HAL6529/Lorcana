using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_08 : CardInfo
{
    public CardInfo_076_JA_08()
    {
        this.cardNo = "076_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "フラワー";
        this.cardName2 = "てれちゃうスカンク";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SandraRios;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
