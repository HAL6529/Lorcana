using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_153_JA_08 : CardInfo
{
    public CardInfo_153_JA_08()
    {
        this.cardNo = "153_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ネズミの女王";
        this.cardName2 = "ネズミ王国の最高支配者";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JonDenskAndHayleyEvans;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
