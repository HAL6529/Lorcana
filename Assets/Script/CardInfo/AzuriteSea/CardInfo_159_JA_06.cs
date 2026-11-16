using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_159_JA_06 : CardInfo
{
    public CardInfo_159_JA_06()
    {
        this.cardNo = "159_JA_06";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ヒーラム・フラバーシャム";
        this.cardName2 = "ハツカネズミの発明家";
        this.power = 0;
        this.toughness = 2;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
