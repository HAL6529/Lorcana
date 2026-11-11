using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_05 : CardInfo
{
    public CardInfo_129_JA_05()
    {
        this.cardNo = "129_JA_05";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "Š¦‚³‚Å“€‚ç‚È‚¢‚æ‚¤‚É‚È";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.LinhDang;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Song;
        this.rare = EnumController.Rare.Rare;
    }
}
