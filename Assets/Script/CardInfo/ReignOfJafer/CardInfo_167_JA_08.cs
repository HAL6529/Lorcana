using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_08 : CardInfo
{
    public CardInfo_167_JA_08()
    {
        this.cardNo = "167_JA_08";
        this.inkCost = 8;
        this.availableInk = true;
        this.cardName1 = "ラティガン";
        this.cardName2 = "天災的天才";
        this.power = 6;
        this.toughness = 7;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
